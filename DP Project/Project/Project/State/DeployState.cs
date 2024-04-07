namespace Project.State
{
    public class DeployState : MyState
    {
        public override void Read()
        {
            Console.Write("You can read from this file.\n");
        }

        public void Write()
        {
            Console.Write("You can write to a file.\n");
        }
        public override void Delete()
        {
            Console.Write("You can delete this file.\n");
        }
        public override void Merge()
        {
            Console.WriteLine("You cannot merge files in this state. Change state to MergedState.\n");
        }
    }
}
