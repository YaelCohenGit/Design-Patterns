namespace Project.Composite
{
    public class Client
    {
        public void PrintContent(Folder f)
        {
            Console.WriteLine($"The folder contents: {f.TreeTraversal()}\n");
        }
        public void IfFolderPrintContent(Folder Folder1, Folder Folder2)
        {
            if (Folder1.IsFolder())
            {
                Folder1.AddFolderToFolder(Folder2);
            }
            Console.WriteLine($"The folder contents: {Folder1.TreeTraversal()}");
        }
    }
}
