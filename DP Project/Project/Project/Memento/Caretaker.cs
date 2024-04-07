using Project.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Memento
{
    public class Caretaker
    {
        private List<IMemento> _commits = new List<IMemento>();

        private GitFile _originator;

        public Caretaker(GitFile originator)
        {
            this._originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Saving GitFile's state...");
            this._commits.Add(this._originator.Save());
        }

        public void Undo()
        {
            if (this._commits.Count == 0)
            {
                return;
            }

            var memento = this._commits.Last();
            this._commits.Remove(memento);

            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());

            try
            {
                this._originator.Restore(memento);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine();
            Console.WriteLine("Caretaker: Here's the list of commits:");

            foreach (var memento in this._commits)
            {
                Console.WriteLine($"At {memento.GetCommitDate()}  =>  {memento.GetName()} ");
            }
        }
    }
}
