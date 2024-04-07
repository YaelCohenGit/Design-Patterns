using Project.State;

namespace Project.Memento
{
    public interface IMemento
    {
        string GetName();

        MyState GetState();

        DateTime GetCommitDate();
    }
}
