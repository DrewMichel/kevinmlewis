using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileWriter[] fileWriters = new IFileWriter[2];
            fileWriters[0] = new TextFileWriter();
            fileWriters[1] = new RtfFileWriter();

            foreach (IFileWriter filewriter in fileWriters)
            {
                filewriter.Write("path" + filewriter.Extension);
            }
        }
    }
}
