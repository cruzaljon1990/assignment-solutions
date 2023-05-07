namespace _02.Hierarchy;
class Program
{
    static void Main(string[] args)
    {
        // Level 1
        Branch root = new Branch();

        // Level 2
        root.branches.Add(new Branch());
        root.branches.Add(new Branch());

        // Level 3
        root.branches[0].branches.Add(new Branch());
        root.branches[1].branches.Add(new Branch());
        root.branches[1].branches.Add(new Branch());
        root.branches[1].branches.Add(new Branch());

        // Level 4
        root.branches[1].branches[0].branches.Add(new Branch());
        root.branches[1].branches[1].branches.Add(new Branch());
        root.branches[1].branches[1].branches.Add(new Branch());

        // Level 5
        root.branches[1].branches[1].branches[0].branches.Add(new Branch());

        Console.WriteLine($"Depth: {root.GetDepth()}");
    }

}

