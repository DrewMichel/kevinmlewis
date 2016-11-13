using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Interface
{
    class RtfFileWriter : IFileWriter
    {
        public string Extension
        {
            get
            {
                return ".rtf";
            }
        }

        public void Write(string filename)
        {
            //write out the format
        }
    }
}
