using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276_Assign_3
{
    abstract class ReadFileDecarator:ReadMorgFile
    {
        private ReadMorgFile wrappedMorgs;

        protected ReadFileDecarator(ReadMorgFile wrapped)
        {
            wrappedMorgs = wrapped;
        }
        protected ReadMorgFile WrappedMorgs { get { return wrappedMorgs; } }

    }
}
