namespace Project.State
{
    class MergedState : MyState
    {
        public override void Delete()
        {
            Console.Write("You cannot delete this file while you're in MergedState. Change state to UnderReview or Draft State.\n");
        }

        public override void Read()
        {
            Console.Write("You can read from this file.\n");
        }
        public void Write()
        {
            Console.Write("you cannot write to this file.\n");
        }

        public static void Merge(string filePath, string filePathupdated)
        {
            try
            {
                string[] lines1 = File.ReadAllLines(filePath);
                string[] lines2 = File.ReadAllLines(filePathupdated);

                //check the number of lines in both files
                int numLines = Math.Min(lines1.Length, lines2.Length);

                for (int i = 0; i < numLines; i++)
                {
                    //compare lines
                    if (lines1[i] != lines2[i])
                    {
                        // print the specific row before and after the change
                        Console.WriteLine($"Before: {lines1[i]}\n");
                        Console.WriteLine($"After: {lines2[i]}\n");

                        //replace line in first file with line from second file
                        lines1[i] = lines2[i];
                    }
                }

                //write modified lines back to the first file
                File.WriteAllLines(filePath, lines1);

                Console.WriteLine("Files merged successfully.\n");
            }
            catch
            {
                Console.WriteLine($"These files cannot be merged.\n");
            }
        }

        public override void Merge()
        {
            Console.WriteLine("You should pass this function 2 files to merge.\n");
        }

    }
}
