using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276_Assign_3
{
   abstract class ReadMorgFile
    {
        public abstract string GetState();
        public abstract void Close();
    }
}
