namespace Project.Composite
{
    public class Folder
    {
        //there is a c# class Directory
        public Folder() { }
        List<GitFile> files = new List<GitFile>();
        List<Folder> folders = new List<Folder>();

        public string TreeTraversal()
        {
            int i = 0;
            string result = "Folder(";

            foreach (GitFile file in files)
            {
                result += file.TreeTraversal();
                if (i != files.Count - 1)
                {
                    result += "+";
                }
                i++;
            }
            return result + ")";
        }
        public void AddFileToFolder(GitFile file)
        {
            files.Add(file);
        }

        public void AddFolderToFolder(Folder folder)
        {
            folders.Add(folder);
        }
        public void RemoveFileFromFolder(GitFile f)
        {
            files.Remove(f);
        }
        public void RemoveFolderFromFolder(Folder f)
        {
            folders.Remove(f);
        }
        public bool IsFolder()
        {
            return true;
        }

    }
}
