using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace ComputersClasses
{
    public abstract class AbstractEntity
    {
        
        public int UUID { get;}
        public static int UUIDnext = 0;



        public AbstractEntity()
        {
            //UUID = Interlocked.Increment(ref UUIDnext);
            UUID = UUIDnext;
            UUIDnext++;
        }
    }
}
