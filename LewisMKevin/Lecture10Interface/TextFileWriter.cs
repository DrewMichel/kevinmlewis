using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Interface
{
    public class TextFileWriter : IFileWriter
    {
        public string Extension
        {
            get { return ".txt"; }
        }

        public void Write(string filename)
        {
            //do your file writing here
        }
    }
}
