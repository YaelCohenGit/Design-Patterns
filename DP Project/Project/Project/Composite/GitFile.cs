using Project.Memento;
using Project.Observer;
using Project.State;


namespace Project.Composite
{
    public class GitFile : Folder, IGitFile
    {
        public string pathName;
        public MyState MyState; //private string _state;   MyState has to be private?
        public GitFile(string pathName)
        {
            this.pathName = pathName;
            // Create() creates a file at pathName 
            //FileStream fs = File.Create(pathName);

            // check if myFile.txt file is created at the specified path 
            if (File.Exists(pathName))
            {
                Console.WriteLine("File is created.");
            }
            else
            {
                Console.WriteLine("File is not created.");
            }
            //fs.Close();
            this.MyState = new DraftState();
        }

        public GitFile() { }

        public void OpenAFile()
        {
            // open a file at pathName 
            FileStream fs = File.Open(pathName, FileMode.Open);
        }
        public void WriteToAFile(string content)
        {
            File.WriteAllText(pathName, content);
        }
        public string FileContent()
        {
            string readText = File.ReadAllText(pathName);
            return readText;
        }
        public new bool IsFolder()
        {
            return false;
        }

        #region observer
        //subject = file

        //public int State { get; set; } = -0;

        // List of subscribers.
        private List<IObserver> _observers = new List<IObserver>();

        // The subscription management methods.
        public void AddFollower(IObserver observer)
        {
            Console.WriteLine("GitFile is followed.");
            this._observers.Add(observer);
        }

        public void RemoveFollower(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("GitFile is not followed.");
        }

        // Trigger an update in each subscriber.
        public void NotifyObservers()
        {
            Console.WriteLine("Notifying managers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\n I'm doing something important.");
            //this.State = new Random().Next(0, 10);

            //Thread.Sleep(1000);

            //Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.NotifyObservers();
        }

        public string GetPathName()
        {
            return pathName;
        }

        #endregion

        #region memento

        public GitFile(string pathName, MyState MyState)
        {
            this.MyState = MyState;
            Console.WriteLine($"GitFile: My initial state is: {MyState}.");

            this.pathName = pathName;
            // Create() creates a file at pathName 
            //FileStream fs = File.Create(pathName);

            // check if myFile.txt file is created at the specified path 
            if (File.Exists(pathName))
            {
                Console.WriteLine("File is created.");
            }
            else
            {
                Console.WriteLine("File is not created.");
            }
            //fs.Close();
        }


        // The Originator's business logic may affect its internal state.
        // Therefore, the client should backup the state before launching
        // methods of the business logic via the save() method.
        public void ChangeToUnderReviewState()
        {
            this.MyState = new UnderReviewState();
            Console.WriteLine("GitFile: my state has changed to UnderReviewState. ");
        }
        public void ChangeToMergedState()
        {
            this.MyState = new MergedState();
            Console.WriteLine("GitFile: my state has changed to MergedState. ");
        }
        public void ChangeToDraftState()
        {
            this.MyState = new DraftState();
            Console.WriteLine("GitFile: my state has changed to DraftState. ");
        }
        public void ChangeToDeployState()
        {
            this.MyState = new DeployState();
            Console.WriteLine("GitFile: my state has changed to DeployState. ");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        // Saves the current state inside a commit.
        public IMemento Save()
        {
            return new Commit(this.MyState);
        }

        // Restores the Originator's state from a commit object.
        public void Restore(IMemento memento)
        {
            if (!(memento is Commit))
            {
                throw new Exception("Unknown commit class " + memento.ToString());
            }

            this.MyState = memento.GetState();
            Console.Write($"GitFile: My state has changed to: {MyState}.");
        }

        #endregion

    }
}
