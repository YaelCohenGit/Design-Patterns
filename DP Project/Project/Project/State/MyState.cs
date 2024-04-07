using Project.Observer;

namespace Project.State
{
    public abstract class MyState
    {
        protected Context? _context;
        public List<Manager> managers = new List<Manager> ();
        public void SetContext(Context context)
        {
            _context = context;
        }
        public void GetState()
        {
            
        }
        public abstract void Read();
        public abstract void Delete();
        public abstract void Merge();

    }
}
