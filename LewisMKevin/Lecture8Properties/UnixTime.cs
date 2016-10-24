using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Properties
{
    class UnixTime
    {
        private long _seconds;
        public long Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                //value is a keyword inside the set block 
                _seconds = value;
            }
        }

        //A property without a backing field.
        public long Minutes
        {
            get
            {
                return _seconds / 60;
            }
        }

        //Auto implemented property
        public string Event { get; set; }

    }
}
