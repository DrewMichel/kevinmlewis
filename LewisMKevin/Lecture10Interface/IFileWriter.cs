using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Interface
{
    public interface IFileWriter
    {
        string Extension { get; }

        void Write(string filename);
    }
}
