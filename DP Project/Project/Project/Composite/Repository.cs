namespace Project.Composite
{
    public class Repository
    {
        List<Branch> branches = new List<Branch>();
        public List<string> commits = new List<string>();

        public void DeleteBranch(Branch b)
        {
            branches.Remove(b);
        }
        public void AddBranch(Branch b)
        {
            branches.Add(b);
        }
        public Branch CreatePrototypeBranch(string branchName)
        {
            Branch Prototype = new Branch();
            foreach (var branch in branches)
            {
                if (branch.branchName == branchName)
                {
                    Prototype = branch;
                }
            }
            branches.Add((Prototype));
            return Prototype.DeepCopy();
        }
        public void PrintAllBranches()
        {
            foreach (var branch in branches)
            {
                branch.PrintBranchName();
            }
        }

        public void PrintAllCommits()
        {
            foreach(var commit in commits)
            {
                Console.WriteLine(commit);
            }
        }
    }
}
