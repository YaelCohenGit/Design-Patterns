using Project.State;
//ע"מ לעשות את הבונוס להכין רשימה של Commit
namespace Project.Memento
{
    public class Commit : IMemento 
    {
        private MyState _state;

        private DateTime _date;

        public Commit(MyState state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        // The Originator uses this method when restoring its state.
        public MyState GetState()
        {
            return this._state;
        }

        // The rest of the methods are used by the Caretaker to display
        // metadata.
        public string GetName()
        {

            return $"{this._state}";

        }

        public DateTime GetCommitDate()
        {
            return this._date;
        }
    }
}
