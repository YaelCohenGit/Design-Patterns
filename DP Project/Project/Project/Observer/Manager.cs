using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Observer
{
    public class Manager : IObserver
    {
        public void Update(IGitFile subject)
        {
            Console.WriteLine("Dear manager! We received a request to review file." + subject.GetPathName());
        }
        public void Update()
        {
            Console.WriteLine("Dear manager! We received a request to review a file.");
        }
    }
}
