using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST276_Assign_3
{
    class Cvs : ReadFileDecarator
    {
        public Cvs(ReadMorgFile wrapped)
            : base(wrapped)
        {
        }

        public override string GetState()
        {

            return WrappedMorgs.GetState().Replace(",","");

        }

        public override void Close()
        {
            WrappedMorgs.Close();
        }
    }
}
