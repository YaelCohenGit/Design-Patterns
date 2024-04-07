namespace Project.Observer
{
    public interface IGitFile // ISubject = IGitFile
    {
        // Attach an observer to the subject.
        void AddFollower(IObserver observer);

        // Detach an observer from the subject.
        void RemoveFollower(IObserver observer);

        // Notify all observers about an event.
        void NotifyObservers();
        string GetPathName();
    }
}
