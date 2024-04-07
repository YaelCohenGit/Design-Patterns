using Project.Composite;
using Project.State;

namespace Project
{
    public class GitService
    {
        public void AddCommit(Repository repository, string message)
        {
            repository.commits.Add(message);
            Console.WriteLine("The commit was added to your repository.");
        }
        public void RemoveLastCommit(Repository repository, string message)
        {
            repository.commits.Remove(message);
            Console.WriteLine("The commit was deleted from your repository.");
        }
        public void RemoveCommitByName(Repository repository, string message)
        {
            foreach (var commit in repository.commits)
            {
                if(commit == message)
                {
                    repository.commits.Remove(message);
                    Console.WriteLine("The commit was deleted from your repository.");
                    return;
                }
            }
            Console.WriteLine("Your specific commit was'nt found. Check for spelling mistakes.");
            Console.WriteLine("Here is a list of all the commits:\n");
            repository.PrintAllCommits();
        }
    }
}
