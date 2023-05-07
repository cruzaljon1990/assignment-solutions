using System;
namespace _02.Hierarchy
{
    public class Branch
    {
        public List<Branch> branches;

        public Branch()
        {
            branches = new List<Branch>();
        }

        public int GetDepth()
        {
            int depth = 1;
            if (branches.Count <= 0) return depth;

            foreach (Branch branch in branches)
            {
                // Get the deepest count
                int branchDepth = branch.GetDepth();
                if (branchDepth > depth)
                {
                    depth = branchDepth;
                }
            }

            return depth + 1;

        }
    }

}

