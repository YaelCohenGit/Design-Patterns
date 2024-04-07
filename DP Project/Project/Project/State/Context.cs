using Project.Composite;

namespace Project.State
{
    public class Context // Context = client
    {
        // A reference to the current state of the Context.
        private MyState? _state = null;
        private bool _wasInUnderReviewState = false;

        public Context(MyState state)
        {
            ChangeState(state);
        }
        public Context()
        {
        }

        // The Context allows changing the State object at runtime.
        public void ChangeState(MyState state)
        {
            if (state is UnderReviewState)
            {
                state.managers.ForEach(m => m.Update());

                _wasInUnderReviewState = true;
                
            }
            if (state is DeployState && _wasInUnderReviewState == false)
            {
                Console.WriteLine("File must go under review before deployment. Change state to UnderReviewState.");
                return;
            }

            Console.WriteLine($"Changed State to {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        public MyState? GetState()
        {
            return _state;
        }

        public void Merge()
        {
            _state?.Merge();
        }
    }
}
