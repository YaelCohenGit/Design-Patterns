using Project;
using Project.Composite;
using Project.Memento;
using Project.Observer;
using Project.State;
class Program
{
    static void Main(string[] args)
    {
        #region Git Service
        //Repository r1 = new Repository();
        //GitService gitService = new GitService();
        //gitService.AddCommit(r1, "DAL Update");
        //gitService.AddCommit(r1, "BL Update");
        //gitService.AddCommit(r1, "Bug fixing");
        //gitService.RemoveLastCommit(r1, "Bug fixing");
        //gitService.RemoveCommitByName(r1, "DAL Update");
        //gitService.RemoveCommitByName(r1, "DALLLL Update");
        #endregion

        #region composite
        //why access to files denied?
        //Client client = new Client();

        //string pathName1 = @"C:\Users\PC\Documents\יעלי\files c sharp made\1";
        //string pathName2 = @"C:\Users\PC\Documents\יעלי\files c sharp made\2";
        //string pathName3 = @"C:\Users\PC\Documents\יעלי\files c sharp made\3";
        //string pathName4 = @"C:\Users\PC\Documents\יעלי\files c sharp made\4";
        //string pathName5 = @"C:\Users\PC\Documents\יעלי\files c sharp made\5";
        //string pathName6 = @"C:\Users\PC\Documents\יעלי\files c sharp made\6";

        //string normalizedPath = Path.GetFullPath(pathName1);

        //GitFile File1 = new GitFile(normalizedPath);

        //GitFile File = new GitFile(pathName2);

        //client.PrintContent(File1);

        //Branch tree = new Branch("main branch");
        //Branch branch1 = new Branch("secondary branch 1");
        //branch1.AddFileToBranch(new GitFile(pathName3));
        //branch1.AddFileToBranch(new GitFile(pathName4));
        //Branch branch2 = new Branch("minor branch 2");
        //branch2.AddFileToBranch(new GitFile(pathName5));
        //Folder folder = new Folder();
        //GitFile file = new GitFile(pathName6);
        //tree.AddFolderToBranch(folder);
        //tree.AddFileToBranch(file);

        //client.PrintContent(tree);
        //client.IfFolderPrintContent(tree, File1);
        #endregion

        #region state
        //DraftState draftState = new DraftState();
        //MergedState mergedState = new MergedState();
        //UnderReviewState underReviewState = new UnderReviewState();
        //var context = new Context(draftState);

        //draftState.Read();
        //draftState.Write();
        //draftState.Delete();
        //draftState.Merge();

        //context.ChangeState(mergedState);
        //mergedState.Read();
        //mergedState.Write();
        //mergedState.Delete();
        //mergedState.Merge();

        //context.ChangeState(underReviewState);
        //underReviewState.Read();
        //underReviewState.Write();
        //underReviewState.Delete();
        //underReviewState.Merge();

        #endregion

        #region observer

        //UnderReviewState underReviewState = new UnderReviewState();
        //var context = new Context();

        //var gitFile = new GitFile();
        //gitFile.MyState = new DraftState();

        //var manager = new Manager();
        //gitFile.AddFollower(manager);

        //context.ChangeState(underReviewState);

        //gitFile.SomeBusinessLogic();
        //gitFile.SomeBusinessLogic();

        //gitFile.RemoveFollower(manager);


        #endregion

        #region memento

        GitFile gitFile = new GitFile("path name", new DraftState());
        Caretaker caretaker = new Caretaker(gitFile);

        caretaker.Backup();
        gitFile.ChangeToDraftState();

        caretaker.Backup();
        gitFile.ChangeToMergedState();

        caretaker.Backup();
        gitFile.ChangeToUnderReviewState();

        caretaker.Backup();
        gitFile.ChangeToDeployState();

        caretaker.ShowHistory();

        Console.WriteLine("\nNow, let's rollback!\n");
        caretaker.Undo();

        Console.WriteLine("\n\nOnce more!\n");
        caretaker.Undo();

        Console.WriteLine();

        #endregion

    }
}
