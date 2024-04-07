using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Project.Observer
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(IGitFile subject);
    }
}
