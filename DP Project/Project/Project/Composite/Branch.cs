namespace Project.Composite
{
    public class Branch : Folder
    {
        public Branch() { }

        public Branch(string branchName)
        {
            this.branchName = branchName;
        }
        public Branch(string branchName, List<Folder> folders, List<GitFile> files)
        {
            this.branchName = branchName;
            this.folders = folders;
            this.files = files;
        }
        public string branchName;
        protected List<Folder> folders = new List<Folder>();
        protected List<GitFile> files = new List<GitFile>();

        public void PrintBranchName()
        {
            Console.WriteLine(branchName);
        }
        public void AddFolderToBranch(Folder Folder)
        {
            folders.Add(Folder);
        }
        public void AddFileToBranch(GitFile f)
        {
            files.Add(f);
        }
        public void RemoveFolderFromBranch(Folder Folder)
        {
            folders.Remove(Folder);
        }
        public void RemoveFileFromBranch(GitFile f)
        {
            files.Remove(f);
        }
        public new string TreeTraversal()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Folder Folder in folders)
            {
                result += Folder.TreeTraversal();
                if (i != folders.Count - 1)
                {
                    result += "+";
                }
                i++;
            }
            return result + ")";
        }

        #region Prototype
        public Branch DeepCopy()
        {
            Branch clone = (Branch)this.MemberwiseClone();
            clone.folders = folders;
            clone.files = files;
            clone.branchName = branchName;
            return clone;
        }
        #endregion

    }
}
