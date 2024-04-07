using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Memento
{
    internal class SomeFunc
    {
        //Substitution for function "Save" in GitFile
        public void CopyFile(string sourceFilePath, string destinationFilePath)
        {
            try
            {
                // Check if the source file exists
                if (!File.Exists(sourceFilePath))
                {
                    Console.WriteLine("Source file does not exist.");
                    return; // Exit the function
                }

                // Copy the contents of the source file to the destination file
                File.Copy(sourceFilePath, destinationFilePath, true);

                Console.WriteLine("File copied successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
